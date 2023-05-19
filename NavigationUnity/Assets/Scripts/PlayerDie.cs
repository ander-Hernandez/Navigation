using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDie : MonoBehaviour
{
    public GameObject playerMoveScript;
    public GameObject deathPanel;
    public Button restartButton;
    public GameObject timeControllerObject;
    private Animator animator;
    private GameStateController timeController;
    private void Start()
    {
        timeController = timeControllerObject.GetComponent<GameStateController>();
        animator = GetComponent<Animator>();

        if (restartButton != null)
        {
            restartButton.onClick.AddListener(RestartScene);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Chase>())
        {
            StartCoroutine(Die());
        }
    }

    private IEnumerator Die()
    {
        animator.SetTrigger("Die");
        //playerMoveScript.SetActive(false);
        yield return new WaitForSeconds(1f);

        if (deathPanel != null)
        {
            deathPanel.SetActive(true);
            animator.enabled = false;
            timeController.pauseGameTime();
        }
    }

    private void RestartScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
