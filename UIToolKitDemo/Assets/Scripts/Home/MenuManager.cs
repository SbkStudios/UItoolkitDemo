using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkit_Demo
{
    public class MenuManager : MonoBehaviour
    {

        #region Variables
        [SerializeField]
        private HomeScreen homeScreen;
        [SerializeField]
        private StoreScreen storeScreen;
        [SerializeField]
        private TeamsScreen teamsScreen;
        [SerializeField]
        private ClanScreen clanScreen;
        [SerializeField]
        private LeaderboardScreen leaderboardScreen;


        [Header("Normal Screens - Which will hide model Screens")]
        [SerializeField]
        private SettingsScreen settingsScreen;
        [SerializeField]
        private FreeRewardsScreen rewardsScreen;
        [SerializeField]
        private ProfileScreen profileScreen;
        [SerializeField]
        private ClanRequirementScreen clanRequirementScreen;


        public UIDocument mainMenuDocument { get; private set; }

        private List<MenuScreen> modelScreens = new List<MenuScreen>();
        #endregion

        #region Unity Methods
        private void Awake()
        {
            mainMenuDocument = GetComponent<UIDocument>();
            
        }

        private void Start()
        {
            SetupModelScreens();
            ShowHomeScreen();
        }

        #endregion

        #region Public Methods
        public void ShowHomeScreen()
        {
            ShowScreen(homeScreen);
        }

        public void ShowStoreScreen()
        {
            ShowScreen(storeScreen);
        }

        public void ShowTeamsScreen()
        {
            ShowScreen(teamsScreen);
        }

        public void ShowClanRequirementScreen()
        {
            clanRequirementScreen?.ShowScreen();
        }
        public void ShowClanScreen()
        {
            ShowScreen(clanScreen);
        }

        public void ShowLeaderboardScreen()
        {
            ShowScreen(leaderboardScreen);
        }

        public void ShowSettingsPanel()
        {
            Debug.Log("MenuManager - Settings Button Clicked");
            settingsScreen?.ShowScreen();
        }

        public void ShowFreeRewardsScreen()
        {
            rewardsScreen?.ShowScreen();
        }

        public void ShowProfileScreen()
        {
            profileScreen?.ShowScreen();
        }
        #endregion

        #region Private Methods
        private void SetupModelScreens()
        {
            if (leaderboardScreen != null)
                modelScreens.Add(leaderboardScreen);

            if (homeScreen != null)
                modelScreens.Add(homeScreen);

            if (storeScreen != null)
                modelScreens.Add(storeScreen);

            if (teamsScreen != null)
                modelScreens.Add(teamsScreen);

            if (clanScreen != null)
                modelScreens.Add(clanScreen);

            
        }

        private void ShowScreen(MenuScreen screenName)
        {
            foreach(MenuScreen screen in modelScreens)
            {
                if(screen == screenName)
                {
                    screen?.ShowScreen();
                }else
                {
                    screen?.HideScreen();
                }
            }
        }
        #endregion
    }
}
