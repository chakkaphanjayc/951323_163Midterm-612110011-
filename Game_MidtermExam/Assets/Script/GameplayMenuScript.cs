using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameplayMenuScript : MonoBehaviour {
    [SerializeField] Button _backButton;
    [SerializeField] Button Stage1;
    [SerializeField] Button Stage2;
    [SerializeField] Button BackStage;
    [SerializeField] Text SText;
    // Start is called before the first frame update
    void Start () {
        _backButton.onClick.AddListener (delegate { BackToMainMenuButtonClick (_backButton); });
    }

    // Update is called once per frame
    void Update () {

    }
    public void BackToMainMenuButtonClick (Button button) {
        SceneManager.LoadScene ("SceneMainMenu");
    }
        public void Stage1ButtonClick (Button button) {
        SceneManager.LoadScene ("SceneGameplayStage1");
    }
        public void Stage2ButtonClick (Button button) {
        SceneManager.LoadScene ("SceneGameplayStage2");
    }
}