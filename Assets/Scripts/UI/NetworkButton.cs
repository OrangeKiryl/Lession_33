using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class NetworkButton : MonoBehaviour
{
  public UnityEvent<Mode> request = new UnityEvent<Mode>();
  [SerializeField] private Mode mode;
  private Button button;

  private void Awake()
  {
    button = GetComponent<Button>();
    button.onClick.AddListener(() => request.Invoke(mode));
  }

  public enum Mode
  {
    Host,
    Client
  }
}
