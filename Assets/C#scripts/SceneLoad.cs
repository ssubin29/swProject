using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SceneLoad : MonoBehaviour
{
    public Slider progressBar;
    public Text loadtext;
    public static string loadScene;
    public static int loadType;
    private void Start()
    {
        StartCoroutine(LoadScene());
    }
    
    public static void LoadSceneHandle(string _name,int _loadType)
    {
        loadScene = _name;
        loadType = _loadType;
        SceneManager.LoadScene("Loading");
    }

    IEnumerator LoadScene()
        {
            yield return null;
            AsyncOperation operation=SceneManager.LoadSceneAsync("Tutorial");
            operation.allowSceneActivation = false;
        /*operation.isDone; 작업의 완료 유무를 boolean 형태로 반환
        operation.progress; 진행정도를 float 형태로 반환(0-진행중,1-진행완료)
        operation.allowSceneActivation; 로딩이 완료되면 바로 씬을 넘김 false면 progress가 0.9f에서 멈춤
        이때 다시 true를 해야 씬을 넘길 수 있음*/
        while (!operation.isDone)
        {
            yield return null;

            if (progressBar.value<0.9f)
            {
                progressBar.value = Mathf.MoveTowards(progressBar.value, 0.9f, Time.deltaTime);
            }else if (progressBar.value >= 0.9f)
            {
                progressBar.value = Mathf.MoveTowards(progressBar.value, 1f, Time.deltaTime);
            }

            if (progressBar.value >= 1f)
            {
                operation.allowSceneActivation = true;
            }
        }
    }

}
