using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke(nameof(RestartGame), 5);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}
