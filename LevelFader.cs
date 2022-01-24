
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelFader : MonoBehaviour
{
    public Animator animator;
    private int levelLoad;
    public GameObject WinScript;
    public bool hasEnteredTrigger;

    void Update()
    {
        if(hasEnteredTrigger == true)
        {
            FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        hasEnteredTrigger = true;
       // FadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void FadeToLevel(int levelIndex)
    {
        levelLoad = levelIndex;
        animator.SetTrigger("FadeOut");
    }
        public void FadeComplete()
    {
        SceneManager.LoadScene(levelLoad);
    }
}
