using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;

namespace UIToolkit_Demo
{
    public class TopPanelScreen : MenuScreen
    {

        #region Variables
        const string CoinsStoreButtonName = "coinsStoreButton";
        const string GemsStoreButtonName = "gemsStoreButton";
        const string settingsButtonName = "settings";
        const string profileElementName = "profileButton";



        private Button coinsStoreButton;
        private Button gemsStoreButton;
        private Button settingsButton;
        private Button profileVisualElement;

        public static Action<ClickEvent> OnStoreClicked;
        #endregion

        #region Unity Methods
        #endregion

        #region Public Methods
        protected override void SetupVisualElements()
        {
            base.SetupVisualElements();

            coinsStoreButton = root.Q<Button>(CoinsStoreButtonName);
            gemsStoreButton = root.Q<Button>(GemsStoreButtonName);
            settingsButton = root.Q<Button>(settingsButtonName);
            profileVisualElement = root.Q<Button>(profileElementName);
        }

        protected override void RegisterButtonEvents()
        {
            base.RegisterButtonEvents();

            coinsStoreButton.RegisterCallback<ClickEvent>(OnStoreButtonClicked);
            gemsStoreButton.RegisterCallback<ClickEvent>(OnStoreButtonClicked);
            settingsButton.RegisterCallback<ClickEvent>(OnSettingsButtonClicked);
            profileVisualElement.RegisterCallback<ClickEvent>(OnProfileButtonclicked);
        }
        #endregion

        #region Private Methods

        private void OnStoreButtonClicked(ClickEvent evnt)
        {
            OnStoreClicked?.Invoke(evnt);
            menuManager.ShowStoreScreen();
        }

        private void OnSettingsButtonClicked(ClickEvent evnt)
        {
            menuManager.ShowSettingsPanel();
        }

        private void OnProfileButtonclicked(ClickEvent evnt)
        {
            menuManager.ShowProfileScreen();
        }
        #endregion

    }
}