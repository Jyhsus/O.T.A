using UnityEngine;

public class Salir : MonoBehaviour
{
    [Header("Panel de Confirmación")]
    public GameObject panelConfirmacion;

    public void MostrarConfirmacion()
    {
        panelConfirmacion.SetActive(true);
    }

    public void ConfirmarSalida()
    {
        Application.Quit();
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void CancelarSalida()
    {
        panelConfirmacion.SetActive(false);
    }
}
