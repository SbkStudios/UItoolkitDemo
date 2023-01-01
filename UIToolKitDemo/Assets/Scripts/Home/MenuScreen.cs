using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkit_Demo
{
    public abstract class MenuScreen : MonoBehaviour
    {

        #region Variables
        [SerializeField]
        protected string screenName;
        [SerializeField]
        protected UIDocument uiDocument;
        [SerializeField]
        protected MenuManager menuManager;

        protected VisualElement screen;
        protected VisualElement root;

        #endregion

        #region Public Methods
        public virtual void OnValidate()
        {
            if (string.IsNullOrEmpty(screenName))
                screenName = this.GetType().Name;
        }

        public virtual void Awake()
        {
            if (uiDocument == null)
                uiDocument = GetComponent<UIDocument>();


            if(uiDocument == null)
            {
                return;
            }else
            {
                SetupVisualElements();
                RegisterButtonEvents();
            }
        }

        protected virtual void SetupVisualElements()
        {
            if (uiDocument != null)
                root = uiDocument.rootVisualElement;
            screen = GetVisualElement(screenName);
        }

        protected virtual void RegisterButtonEvents()
        {

        }

        public void ShowVisualElement(VisualElement visualElement, bool status)
        {
            if (visualElement == null)
                return;
            visualElement.style.display = (status) ? DisplayStyle.Flex : DisplayStyle.None;
        }

        public virtual void ShowScreen()
        {
            ShowVisualElement(screen, true);
        }

        public virtual void HideScreen()
        {
            if (IsVisible())
            {
                ShowVisualElement(screen, false);
            }
        }

        public virtual string GetScreenName()
        {
            return screenName;
        }

        public bool IsVisible()
        {
            if (screen == null)
                return false;
            return (screen.style.display == DisplayStyle.Flex);
        }
        #endregion

        #region Private Methods
        
        private VisualElement GetVisualElement(string screenName)
        {
            if (string.IsNullOrEmpty(screenName) || root == null)
                return null;
            return root.Q(screenName);
        }
        #endregion
    }
}
