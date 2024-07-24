using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NetworkButtons : MonoBehaviour
{
  [SerializeField] private NetworkButton[] buttons;
  public UnityEvent<NetworkButton.Mode> request = new();

  private void Start()
  {
    foreach (var button in buttons)
    {
      button.request.AddListener((mode) => request.Invoke(mode));
    }
  }

  public void Hide()
  {
    foreach (var button in buttons)
    {
      button.gameObject.SetActive(false);
    }
  }
}
