using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SnackbarManager : MonoBehaviour
{
    [SerializeField] private GameObject snackbarPrefab;
    [SerializeField] private Transform snackbarParent;
    [SerializeField] private float duration;

    public void ShowSnackbar(string message)
    {
        GameObject snackbar = Instantiate(snackbarPrefab, snackbarParent);
        TMP_Text snackbarText = snackbar.GetComponentInChildren<TMP_Text>();
        snackbarText.text = message;
        Destroy(snackbar, duration);
    }
}
