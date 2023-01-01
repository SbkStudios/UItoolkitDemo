using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkit_Demo
{
    public class ProfileScreen : MenuScreen
    {
        #region Variables
        const string closeButtonName = "closeButton_profile";

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
            closeButton.RegisterCallback<ClickEvent>(OncloseButtonClicked);
        }
        #endregion

        #region Private Methods
        private void OncloseButtonClicked(ClickEvent evnt)
        {
            HideScreen();
        }
        #endregion
    }
}
