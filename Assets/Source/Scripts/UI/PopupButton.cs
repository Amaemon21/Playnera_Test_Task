using UnityEngine;
using UnityEngine.SceneManagement;

public class PopupButton : MonoBehaviour
{
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnClickBackButton()
    {
        _animator.SetTrigger(UIPopupAnimatorData.Params.Hide);
    }

    public void OnClickExitButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HidePopup()
    {
        gameObject.SetActive(false);
    }
}