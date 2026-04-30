using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeScriptOutro : MonoBehaviour
{

    public CanvasGroup canvasGroup;
    public float fadeDuration = 2.0f;

    public float fadeOutSeconds;
    public float changeSceneSeconds;

    public bool fadeIn = false;

    public string sceneName;

    void Start()
    {

        FadeIn();

        StartCoroutine(FadeOutTime());
        
    }

    IEnumerator FadeOutTime()
    {
        yield return new WaitForSeconds(fadeOutSeconds);
        FadeOut();
        yield return new WaitForSeconds(changeSceneSeconds);
        SceneManager.LoadScene(sceneName);
    }

    public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(canvasGroup, canvasGroup.alpha, 0, fadeDuration));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(canvasGroup, canvasGroup.alpha, 1, fadeDuration));
    }

    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float duration)
    {
        float elapsedTime = 0.0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            cg.alpha = Mathf.Lerp(start, end, elapsedTime / duration);
            yield return null;
        }

        cg.alpha = end;
    }
}
