using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Kits.CommonControls;

namespace Kits.CommonUtils
{
    public class WorkFlowManager
    {
        #region Private Instance fields
        private static Dictionary<string, WorkFlowManager> workflows = new Dictionary<string, WorkFlowManager>();
        private static WorkFlowManager activeWorkFlow = null;
        private static string activeWorkFlowName = string.Empty;
        private ScrollableControl container;
        private static string currentWorkFlowName = string.Empty;
        private static Type mainPanelType = null;
        private Stack<BasePanel> previousPanelStack = new Stack<BasePanel>();
        private Type initialPanelType = null;        
        #endregion
        public enum FlowAction
        {
            /// Clear Action
            Clear,
            /// Load Action
            Load
        }
        #region Public Instance fields
        /// <summary>
        /// To set the value of the scrollable container
        /// </summary>
        public ScrollableControl Container
        {
            set { container = value; }
            get { return container; }
        }
        public Type InitialPanelType
        {
            set { initialPanelType = value; }
        }
        #endregion
        public static WorkFlowManager ActiveWorkFlow
        {
            set { activeWorkFlow = value; }
            get { return activeWorkFlow; }
        }
        public Type MainMenuPanel
        {
            set { mainPanelType = value; }
            get { return mainPanelType; }
        }
        #region Public methods
        public static WorkFlowManager Create(string name, ScrollableControl container, Type panelType)
        {
            WorkFlowManager workflow = new WorkFlowManager();
            workflow.Container = container;
            workflow.InitialPanelType = panelType;
            workflows.Add(name, workflow);
            activeWorkFlowName = name;
            return workflow;
        }
        public static WorkFlowManager Activate(string name)
        {
            WorkFlowManager workflow = workflows[name];
            ActiveWorkFlow = workflow;
            workflow.CreateFirst();
            activeWorkFlowName = name;
            return workflow;
        }
        public void CreateFirst()
        {
            if (activeWorkFlow.previousPanelStack.Count == 0)
            {
                ShowFirstPanel(initialPanelType);
            }
        }
        public void ShowFirstPanel(Type panelType)
        {
            Cursor.Current = Cursors.WaitCursor;
            BasePanel panel = null;
            try
            {

                initialPanelType = panelType;
                panel = (BasePanel)Activator.CreateInstance(panelType);
                activeWorkFlow.previousPanelStack.Push(panel);
                DisplayPanel(panel);
                panel.InitializePanel();
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        private void DisplayPanel(BasePanel panel)
        {
            container.Controls.Clear();
            container.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.Show();
            panel.Focus();
            panel.OnPanelActive();
        }
        private void ExitApplication()
        {
            if (activeWorkFlow.previousPanelStack.Count > 0)
            {
                this.ReleaseAppStack();
            } 
            Application.Exit();            
        }
        private void ReleaseAppStack() 
        {
            while ((previousPanelStack.Count > 0))
            {
                previousPanelStack.Pop();
            }
        }
        private void PerformScreenActions(FlowAction action)
        {
            if (action == FlowAction.Clear)
            {
                previousPanelStack.Peek().Clear();
            }
            else
            {
                if (action == FlowAction.Load)
                {
                    previousPanelStack.Peek().Load();
                }
            }
        }
        public void Exit()
        {
            //Can check with user if data will be lost or saved
            this.ExitApplication();
        }
        public void ShowNextPanel(Type panelType)
        {
            Cursor.Current = Cursors.WaitCursor;

            BasePanel panel = null;
            try
            {
                initialPanelType = panelType;
                panel = (BasePanel)Activator.CreateInstance(panelType);
                previousPanelStack.Push(panel);
                DisplayPanel(panel);
                panel.InitializePanel();  
            }
            catch (Exception ex)
            {
            
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        public void ShowNextPanel(Type panelType, FlowAction action)
        {
            ShowNextPanel(panelType);
            PerformScreenActions(action);
        }
        public void ShowPreviousPanel()
        {
            try
            {
                if (previousPanelStack.Count == 0)
                {
                    string exceptionMessage = "Previous panel does not exist";
                    throw new Exception(exceptionMessage);
                }
                BasePanel panel = previousPanelStack.Pop();
                DisplayPanel(previousPanelStack.Peek());
            }
            catch (Exception ex)
            {

            }
            finally
            {
             
            }
        }
        public void ShowPreviousPanel(string panelName, FlowAction action)
        {
            ShowPreviousPanel(panelName);
            PerformScreenActions(action);
        }
        public void ShowPreviousPanel(string panelName)
        {
            try
            {
                // Unwind the stack until the main menu is reached (it is always the first panel in the workflow 
                // manager).
                while ((previousPanelStack.Count > 1) &&
                    (previousPanelStack.Peek().Name != panelName))
                {
                    //nextPanelStack.Push(previousPanelStack.Pop());
                    previousPanelStack.Pop();
                }
                // Display the next panel on the stack
                if (previousPanelStack.Count >= 1)
                {
                    DisplayPanel(previousPanelStack.Peek());
                }

                //there are no more panels.  The programmer has made a mistake.
                else
                {
                    string exceptionMessage = panelName.ToString() +
                        " does not exist in the previous panel stack.";
                    throw new InvalidOperationException(exceptionMessage);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
        }
        #endregion
    }
}