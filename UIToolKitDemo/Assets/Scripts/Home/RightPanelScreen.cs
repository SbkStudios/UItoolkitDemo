using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkit_Demo
{
    public class RightPanelScreen : MenuScreen
    {

        #region Variables
        const string freeRewardsButtonName = "button_free_rewards";


        Button freeRewardsButton;
        #endregion

        #region Public Methods
        protected override void SetupVisualElements()
        {
            base.SetupVisualElements();
            freeRewardsButton = root.Q<Button>(freeRewardsButtonName);
        }

        protected override void RegisterButtonEvents()
        {
            base.RegisterButtonEvents();
            freeRewardsButton.RegisterCallback<ClickEvent>(OnFreeRewardsButtonClicked);
        }
        #endregion

        #region Private Methods

        private void OnFreeRewardsButtonClicked(ClickEvent evnt)
        {
            menuManager.ShowFreeRewardsScreen();
        }
        #endregion
    }
}