using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityEngine.SceneManagment;
public class Nextlevel : MonoBehaviour
{
    private void onCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NextLevel"))
        {
        SceneManager.LoadScene(SceneManager.getActiveScene("Level 1 Part 2").name)
        }

    }
}