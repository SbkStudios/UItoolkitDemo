using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkit_Demo
{
    public class MenuBarScreen : MenuScreen
    {
        #region Variables
        private const string storeButtonName = "storeButton";
        private const string teamsButtonName = "teamsButton";
        private const string homeScreemButtonName = "homeScreenButton";
        private const string clanButtonName = "clanButton";
        private const string leaderboardButtonName = "leaderBoardButton";


        // Classes
        const string buttonInActiveClass = "menu_button";
        const string buttonActiveClass = "menu_button_active";

        const string labelInActiveClass = "button_label";
        const string labelActiveClass = "button_label_active";

        Button storeButton;
        Button teamsButton;
        Button homeScreenButton;
        Button clanButton;
        Button leaderBoardButton;

        Button dummyButton;
        #endregion

        #region Public Methods

        private void OnEnable()
        {
            TopPanelScreen.OnStoreClicked += OnStoreButtonClicked;

        }

        private void OnDisable()
        {
            TopPanelScreen.OnStoreClicked -= OnStoreButtonClicked;
        }
        protected override void SetupVisualElements()
        {
            base.SetupVisualElements();
            storeButton = root.Q<Button>(storeButtonName);
            teamsButton = root.Q<Button>(teamsButtonName);
            homeScreenButton = root.Q<Button>(homeScreemButtonName);
            clanButton = root.Q<Button>(clanButtonName);
            leaderBoardButton = root.Q<Button>(leaderboardButtonName);
        }
        protected override void RegisterButtonEvents()
        {
            base.RegisterButtonEvents();
            storeButton.RegisterCallback<ClickEvent>(OnStoreButtonClicked);
            teamsButton.RegisterCallback<ClickEvent>(OnTeamsButtonClicked);
            homeScreenButton.RegisterCallback<ClickEvent>(OnHomescreenButtonClicked);
            clanButton.RegisterCallback<ClickEvent>(OnClanButtonClicked);
            leaderBoardButton.RegisterCallback<ClickEvent>(OnLeaderboardButtonClicked);
        }

        #endregion

        #region Private Methods

        private void OnStoreButtonClicked(ClickEvent evnt)
        {
            Debug.Log("Store button clicked");
            ActivateButton(storeButton);
            menuManager.ShowStoreScreen();
        }

        private void OnTeamsButtonClicked(ClickEvent evnt)
        {
            ActivateButton(teamsButton);
            menuManager.ShowTeamsScreen();
        }

        private void OnHomescreenButtonClicked(ClickEvent evnt)
        {
            ActivateButton(homeScreenButton);
            menuManager.ShowHomeScreen();
        }

        private void OnClanButtonClicked(ClickEvent evnt)
        {
            menuManager.ShowClanRequirementScreen();
            return;
            ActivateButton(clanButton);
            menuManager.ShowClanScreen();
        }

        private void OnLeaderboardButtonClicked(ClickEvent evnt)
        {
            ActivateButton(leaderBoardButton);
            menuManager.ShowLeaderboardScreen();
        }

        private void ActivateButton(Button selectedButton)
        {
            if (selectedButton == null)
                return;

            HightLightElement(selectedButton, buttonActiveClass, buttonInActiveClass, root);

            //Label
            Label label = selectedButton.Q<Label>(className: labelInActiveClass);
            HightLightElement(label, labelActiveClass, labelInActiveClass, root);
        }

        private void HightLightElement(VisualElement selectedElement, string activeClass, string inActiveClass, VisualElement root)
        {
            if (selectedElement == null)
                return;

            VisualElement currentSelected = root.Query<VisualElement>(className: activeClass);

            if (currentSelected == selectedElement)
                return;

            currentSelected.RemoveFromClassList(activeClass);
            currentSelected.AddToClassList(inActiveClass);

            selectedElement.RemoveFromClassList(inActiveClass);
            selectedElement.AddToClassList(activeClass);
        }
        #endregion
    }
}
