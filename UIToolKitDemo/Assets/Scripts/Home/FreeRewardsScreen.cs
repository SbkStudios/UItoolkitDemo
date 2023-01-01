using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkit_Demo
{
    public class FreeRewardsScreen : MenuScreen
    {
        #region Variables

        const string closeButtonName = "closeButton_rewards";


        Button closeButton;

        #endregion

        #region Public Methods
        protected override void SetupVisualElements()
        {
            base.SetupVisualElements();
            closeButton = root.Q<Button>(closeButtonName);
        }

        protected override void RegisterButtonEvents()
        {
            base.RegisterButtonEvents();
            closeButton.RegisterCallback<ClickEvent>(OnCloseButtonClicked);
        }
        #endregion

        #region Private Methods
        private void OnCloseButtonClicked(ClickEvent evnt)
        {
            Debug.Log("Close Button clicked");
            HideScreen();
        }
        #endregion
    }
}
