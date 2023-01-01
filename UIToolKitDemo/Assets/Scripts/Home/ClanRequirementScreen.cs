using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkit_Demo
{
    public class ClanRequirementScreen : MenuScreen
    {

        #region Variables
        const string closeButtonName = "clanRequirement_CloseButton";


        Button closeButton;
        #endregion

        #region Unity Methods
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
            HideScreen();
        }
        #endregion
    }
}