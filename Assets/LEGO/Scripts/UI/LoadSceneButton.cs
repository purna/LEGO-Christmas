using Unity.LEGO.Game;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

namespace Unity.LEGO.UI
{
    public class LoadSceneButton : MonoBehaviour
    {
        public string sceneName = "";
        
        public string buttonName = "Play";
        public Sprite buttonImage;

        public void Start()
        {

           transform.GetChild(0).GetComponent<TMP_Text>().text = buttonName;
           transform.GetChild(1).GetComponent<Image>().sprite = buttonImage;


        }

        public void LoadScene()
        {
            SceneManager.LoadScene(sceneName);
        }

        public void LoadPreviousScene()
        {
            if (GameFlowManager.PreviousScene != null)
            {
                SceneManager.LoadScene(GameFlowManager.PreviousScene);
            }
            else
            {
                LoadScene();
            }
        }
    }
}