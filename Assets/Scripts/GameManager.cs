using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GameManager : MonoBehaviour
{

    public int score = 0;
    [SerializeField] public int addScore = 20;
    [SerializeField] public int bonusScore = 40;
    [SerializeField] Text txtScore;

    Frog frog;

    public bool isDead;

    private void Awake()
    {
        frog = FindObjectOfType<Frog>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      
    }

    public void AddScore(int points)
    {
        Debug.Log("Add Score");
        score += points;
        txtScore.text = score.ToString();
    }
    public void GameOver()
    {
        FindObjectOfType<Followcamera>().enabled = false;
        DOTween.KillAll();
    }
}
