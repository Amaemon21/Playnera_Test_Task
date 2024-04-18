using UnityEngine;

public class StartButton : MonoBehaviour 
{ 
    [SerializeField] private ParticleSystem _particleSystem;
    [SerializeField] private UIPulsate _UIPulsate;

    private void Awake()
    {
        _UIPulsate.StartPulsating();

        _particleSystem.gameObject.SetActive(false);
        _particleSystem.Stop();
    }

    public void StartGame()
    {
        _particleSystem.gameObject.SetActive(true);
        _particleSystem.Play();

        _UIPulsate.StopPulsating();
    }
}