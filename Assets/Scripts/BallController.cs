using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BallController : MonoBehaviour
{
    public int force;
    Rigidbody2D rigid;
    private int count;
    public Text countText;
    public Text NoticeText;
    AudioSource audio;
    public AudioClip hitSound;
    
    void SetCountText()
    {
        countText.text = "Point: " + count.ToString();
    }

    // Use this for initialization
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Vector2 arah = new Vector2(0, -2).normalized;
        rigid.AddForce(arah * force);
        count = 0;
        SetCountText();
        NoticeText.text = "Level C-1";
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "TepiBawah")
        {
            SceneManager.LoadScene("Gameover");
            audio.PlayOneShot(hitSound);
        }
        if (coll.gameObject.name == "TepiKiri")
        {
            audio.PlayOneShot(hitSound);
        }
        if (coll.gameObject.name == "TepiKanan")
        {
            audio.PlayOneShot(hitSound);
        }
        if (coll.gameObject.name == "TepiAtas")
        {
            audio.PlayOneShot(hitSound);
        }


        if (coll.gameObject.name == "Paddle")
        {
            float sudut = (transform.position.x - coll.transform.position.x) * 4f;
            Vector2 arah = new Vector2(sudut, rigid.velocity.y).normalized;
            rigid.velocity = new Vector2(0, 0);
            rigid.AddForce(arah*force*2);
            audio.PlayOneShot(hitSound);
        }

        if(coll.gameObject.name == "P1")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 20;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }

        if (coll.gameObject.name == "P2")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 20;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }

        if (coll.gameObject.name == "P3")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 20;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }

        if (coll.gameObject.name == "P4")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 20;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }

        if (coll.gameObject.name == "P5")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 20;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }
        if (coll.gameObject.name == "P6")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 10;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }
        if (coll.gameObject.name == "P7")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 10;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }
        if (coll.gameObject.name == "P8")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 10;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }
        if (coll.gameObject.name == "P9")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 10;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }
        if (coll.gameObject.name == "P10")
        {
            if (coll.gameObject.CompareTag("Persegi"))
            {
                coll.gameObject.SetActive(false);
                count = count + 10;
                SetCountText();
                if (count >= 100)
                {
                    SceneManager.LoadScene("Level2");
                }
                audio.PlayOneShot(hitSound);
            }

        }

    }
    void ResetBall()
    {
        transform.localPosition = new Vector2(0, -1);
        rigid.velocity = new Vector2(0, 0);
    }

}
