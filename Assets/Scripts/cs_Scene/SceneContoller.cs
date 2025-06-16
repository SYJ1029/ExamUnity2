using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using Unity.VisualScripting.InputSystem;


public class SceneController : MonoBehaviour
{
    public static SceneController Instance { get; private set; }

    Scene scene;
    int sceneIndex;


    private void Awake()
    {
        // 싱글톤 생성
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬 전환 시 파괴되지 않음
        }
        else
        {
            Destroy(gameObject); // 중복 방지
        }
    }

 
    public void LoadSceneByIndex(int index)
    {
        if (index < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(index);
        }
        else
        {
            Debug.LogWarning("존재하지 않는 씬 인덱스입니다.");
        }
    }

    public void OnNextScene()
    {
        int newSceneIndex = SceneManager.GetActiveScene().buildIndex;

        newSceneIndex++;
        newSceneIndex %= SceneManager.sceneCountInBuildSettings;

        if (newSceneIndex == 0)
            newSceneIndex++;

        LoadSceneByIndex(newSceneIndex);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKeyDown(KeyCode.N))
        //{
        //    OnNextScene();
        //}
    }
}
