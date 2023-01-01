using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;


namespace UIToolkit_Demo
{
    public class SplashScreen : MonoBehaviour
    {
        #region Variables
        [SerializeField]
        private UIDocument uiDocument;
        [SerializeField]
        private string sceneToLoad;

        private float timerToLoad = 5f;
        private float timer;
        private float percentage;
        private bool loadScene = false;

        private VisualElement root;
        private ProgressBar loadingProgress;

        private Button dummyButton;


        private const string Progressbar = "LoadingProgress";
        #endregion

        #region Public Methods
        private void Awake()
        {
            SetupUiElements();
        }

        private void Update()
        {
            if(!loadScene)
            {
                timer += Time.deltaTime;
                percentage = Mathf.Round((timer / timerToLoad) * 100);
                loadingProgress.value = percentage;
                if (timer >= timerToLoad)
                    loadScene = true;

                //if (loadScene)
                //    SceneManager.LoadScene(sceneToLoad);
            }
        }
        #endregion

        #region Private Methods

        private void SetupUiElements()
        {
            root = uiDocument.rootVisualElement;
            loadingProgress = root.Q<ProgressBar>(Progressbar);
            dummyButton = root.Q<Button>("dummyButton");
            dummyButton.RegisterCallback<ClickEvent>(OnDummyButtonClicked);
        }


        private void OnDummyButtonClicked(ClickEvent evnt)
        {
            Debug.Log("Dummy Button clicked");
        }
        #endregion
    }
}
