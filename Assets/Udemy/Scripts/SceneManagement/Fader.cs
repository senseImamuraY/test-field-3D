using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.SceneManagement
{
  public class Fader : MonoBehaviour
  {
    CanvasGroup canvasGroup;

    private void Start()
    {
     canvasGroup = GetComponent<CanvasGroup>();
      //StartCoroutine(FadeOutIn());
    }
    //IEnumerator FadeOutIn()
    //{
    //  yield return FadeOut(3f);
    //  print("Faded out");
    //  yield return FadeIn(1f);
    //  print("Faded out");
    //}

    public IEnumerator FadeOut(float time)
    {
      // yield retrun  null��1�t���[�����ƂɎ��s�����Ƃ����Ӗ�
      while (canvasGroup.alpha < 1)
      {
        canvasGroup.alpha += Time.deltaTime / time;
        yield return null;
      }
    }
    public IEnumerator FadeIn(float time)
    {
      // yield retrun  null��1�t���[�����ƂɎ��s�����Ƃ����Ӗ�
      while (canvasGroup.alpha > 0)
      {
        canvasGroup.alpha -= Time.deltaTime / time;
        yield return null;
      }
    }
  }
}
