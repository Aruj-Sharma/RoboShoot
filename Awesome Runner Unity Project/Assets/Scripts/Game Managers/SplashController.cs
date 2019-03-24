using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashController : MonoBehaviour
{
    [SerializeField]
    private Image background;


     IEnumerator Start()
    {
      //  background.canvasRenderer.SetAlpha(0.0f);

     //   background.CrossFadeAlpha(1.0f,2.5f,false);

        yield return new WaitForSeconds(2.5f);

      //  background.CrossFadeAlpha(0.0f, 2.5f, false);

        yield return new WaitForSeconds(2.5f);

        SceneManager.LoadScene(Tags.MAINMENU_SCENE);
    }

   
}
