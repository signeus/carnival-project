using UnityEngine;

public class CounterTime : MonoBehaviour {

    [SerializeField]
    private float timeRemaining = 60 * 2 + 1;

    private CarnivalScores cs;

    void Start()
    {
        cs = CarnivalScores.Instance;
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            float minutes = Mathf.Floor(timeRemaining / 60);
            float seconds = Mathf.Floor(timeRemaining % 60);
            cs.Time.text = " " + minutes.ToString("00") + ":" + seconds.ToString("00");
        }

        if(timeRemaining <= 0)
        {
            if (!CarnivalScores.Instance.IsOver)
            {
                CarnivalScores.Instance.GameOver();
            }
        }else
        {
            timeRemaining -= Time.deltaTime;
        }
    }
}
