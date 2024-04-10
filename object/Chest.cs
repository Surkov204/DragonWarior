
using UnityEngine;

public class Chest : MonoBehaviour
{
    private Animator anim;
    [SerializeField] private AudioClip soundopen;
    [SerializeField] private AudioClip soundclose;
    public GameObject pic;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            anim.SetTrigger("open");
            Audio.instance.PlaySound(soundopen);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            anim.SetTrigger("close");
            Audio.instance.PlaySound(soundclose);
        }
    }
    public void Deactivate()
    {
        anim.SetTrigger("hold");
        pic.SetActive(true);
    }

    public void CloseDeactivate()
    {
        anim.SetTrigger("alreadyClose");
        pic.SetActive(false);
    }
}
