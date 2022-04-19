using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject player;
    public GameObject EndUI;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            EndUI.SetActive(true);
            player.GetComponent<Player>().canWalk = false;
            player.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Invoke(nameof(RestartGame), 5);
        }
    }
    public void RestartGame()
    {
        player.GetComponent<Player>().RestartGame();
    }
}
