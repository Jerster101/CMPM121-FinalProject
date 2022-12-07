using UnityEngine;
using System.Collections;
public class HighlightObject : MonoBehaviour
{
  private Color initialColor;
  public bool noEmissionAtStart = true;
  public Color highlightColor = Color.red;
  public Color mousedownColor = Color.green;
  public static int PageCount = 0;

  public Material skyboxOne;
  public Material skyboxTwo;
  private Light[] lights;

  private bool mouseon = false;
  private Renderer myRenderer;

  public AudioSource drums;
  public AudioSource ambience;
  public AudioSource whisper;
  public AudioSource crow;
  public AudioSource hurray;

  void Start() {
    RenderSettings.skybox = skyboxOne;
    Debug.Log("Page Count = " + PageCount);
    myRenderer = GetComponent<Renderer>();
    if (noEmissionAtStart)
    initialColor = Color.black;
    else
    initialColor = myRenderer.material.GetColor("_EmissionColor");
  }

  void OnMouseEnter(){
    mouseon = true;
    myRenderer.material.SetColor("_EmissionColor", highlightColor);
  }

  void OnMouseExit(){
    mouseon = false;
    myRenderer.material.SetColor("_EmissionColor",initialColor);
  }

  void OnMouseDown(){
    myRenderer.material.SetColor("_EmissionColor", mousedownColor);
    Destroy(gameObject, 0.1f);
    PageCount += 1;
    Debug.Log("Page Count = " + PageCount);
    
    if (PageCount == 1)
    {
      ambience.enabled = true;
    }
    if (PageCount == 2)
    {
      crow.enabled = true;
    }
    if (PageCount == 3)
    {
      drums.enabled = true;
    }
    if (PageCount == 4)
    {
      whisper.enabled = true;
    }
    if (PageCount == 5)
    {
        RenderSettings.skybox = skyboxTwo;
        lights = FindObjectsOfType(typeof(Light)) as Light[];
         foreach(Light light in lights)
         {
             light.intensity = 0.5f;
         }
         hurray.enabled = true;
    }

  }

  void OnMouseUp(){
    if (mouseon)
    myRenderer.material.SetColor("_EmissionColor", highlightColor);
    else
    myRenderer.material.SetColor("_EmissionColor", initialColor);
  }
}