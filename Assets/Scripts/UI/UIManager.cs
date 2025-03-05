using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject pauseMenuQuitUI;
    public static bool isPaused = false;
    public static GameObject prefabUI;
    public static Transform self;
    [SerializeField]private GameObject tmpUI;
    void Start()
    {
        prefabUI = tmpUI;
        self = transform;
    }
    void Update()
    {
        //UpdateOrderUI();
        Time.timeScale = isPaused ? 0f : 1f;
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused) ResumeGame();
            else PauseGame();
        }
    }
    public void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseMenuUI.SetActive(true);
        isPaused = true;
    }
    public void PauseMenuQuit()
    {
        bool tmp = !pauseMenuQuitUI.activeSelf;
        pauseMenuQuitUI.SetActive(tmp);
        pauseMenuUI.SetActive(!tmp);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void QuitToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public static GameObject CreateOrderUI(CustomerManager.Request request)
    {
        GameObject UI = Instantiate(prefabUI, self);
        UI.GetComponent<OrderUI>().request = request;
        CustomerManager.orderUIList.Add(UI);
        Debug.Log("created UI");
        return UI;
    }
    private void UpdateOrderUI()
    {
        for(int i = 0; i < CustomerManager.orderUIList.Count; i++)
        {
            CustomerManager.orderUIList[i].GetComponent<RectTransform>().position = new Vector3(-480 + (130 * i), -170, 0);
        }
    }
}
