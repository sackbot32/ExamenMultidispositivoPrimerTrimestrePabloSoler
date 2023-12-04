using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoFill : MonoBehaviour
{
    public GaleriaList galeriaList;
    public GameObject prefabImagen;
    public Text descripcion;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (ObjetoGaleria item in galeriaList.galeriaList)
        {
            GameObject instanciado = Instantiate(prefabImagen, transform);
            Fill(item, instanciado);
            instanciado.GetComponent<Button>().onClick.AddListener(() => ShowDescription(item));
        }
    }

    private void Fill(ObjetoGaleria objeto, GameObject instancia)
    {
        instancia.transform.GetChild(0).transform.GetComponent<Image>().sprite = objeto.image;
        instancia.transform.GetChild(1).transform.GetComponent<Text>().text = objeto.name;
    }

    private void ShowDescription(ObjetoGaleria objeto)
    {
        descripcion.text = "Descripcion:" + objeto.description;
    }
}
