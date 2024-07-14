using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameRecorder : MonoBehaviour
{
    #region Singleton
    public static GameRecorder Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    private float _secs;
    private int _mins;
    private int _hrs;

    [SerializeField] private string _time;
    [SerializeField] private int _deaths = 0;
    [SerializeField] Text _timeText, _deathText;


    public void StartTimer()
    {
        StartCoroutine("Timer");
    }

    public void AddDeath()
    {
        _deaths++;
    }

    private IEnumerator Timer()
    {
        while (_hrs < 2)
        {
            _secs += Time.deltaTime;

            if (_secs >= 60)
            {
                _mins++;
                _secs -= 60;
            }

            if (_mins >= 60)
            {
                _hrs++;
                _mins -= 60;
            }

            _time = $"{_hrs:00}h {_mins:00}m {_secs:00s.000}";

            yield return null;
        }
    }

    public void GetTime()
    {
        _timeText.text = _time;
    }

    public void GetDeaths()
    {
        _deathText.text = $"You have died {_deaths:00} times!";
    }
}
