using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToastManager : MonoBehaviour
{
    [SerializeField] private GameObject toastPrefab;
    [SerializeField] private Transform toastParent;
    [SerializeField] private float duration;

    public void ShowToast(string message)
    {
        GameObject toast = Instantiate(toastPrefab, toastParent);
        TMP_Text toastText = toast.GetComponentInChildren<TMP_Text>();
        toastText.text = message;
        Destroy(toast, duration);
    }
}
