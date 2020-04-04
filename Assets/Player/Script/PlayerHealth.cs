using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    protected int x = 100;
    public int PlayerLife
    {
        get { return x; }
        set { x = value; }
    }


    //[SerializeField] GameObject life;
   // void Update()
    //{
       // life.GetComponent<TextMesh>().text = System.Convert.ToString(PlayerLife);
        //if (PlayerLife == 0)
        //{
        //    SceneManager.LoadScene(sceneName:"Death");
        //}
    //}
}
