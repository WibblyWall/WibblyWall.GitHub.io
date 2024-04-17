using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    [SerializeField] BoxCollider2D playerCollider;
    GameObject currentOneWayPlatform;
    public float platTime;
    public void Update()
    {
        if (Input.GetAxis("Vertical") <= -0.5)
        {
            if (currentOneWayPlatform != null)
            {
                StartCoroutine(DisableCollison());
            }
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("OneWayPlatform"))
        {
            currentOneWayPlatform = collision.gameObject;
        }
    }
    public void OnCollisionExit2D(Collision2D collision)
    {
          if(collision.gameObject.CompareTag("OneWayPlatform"))
        {
            currentOneWayPlatform = null;
        } 
    }
    IEnumerator DisableCollison()
    {
        BoxCollider2D platformCollider = currentOneWayPlatform.gameObject.GetComponent<BoxCollider2D>();
        Physics2D.IgnoreCollision(playerCollider, platformCollider);
        yield return new WaitForSeconds(platTime);
        Physics2D.IgnoreCollision(playerCollider, platformCollider, false);
    }
}
