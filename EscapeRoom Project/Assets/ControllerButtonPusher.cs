using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerButtonPusher : MonoBehaviour {

    private ArrayList code;
	private ArrayList rightCode;
	public AudioSource hit;
    //public AudioSource wrong;
    //public AudioSource right;
    public bool open;

	private Rigidbody rb;

	void Start ()
	{
        rightCode = new ArrayList();
        rightCode.Add(1);
        rightCode.Add(2);
        rightCode.Add(3);
        rightCode.Add(4);
        code = new ArrayList();
        open = false;
    }

	void FixedUpdate ()
	{
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Zero"))
        {
            code.Add(0);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("One"))
        {
            code.Add(1);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("Two"))
        {
            code.Add(2);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("Three"))
        {
            code.Add(3);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("Four"))
        {
            code.Add(4);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("Five"))
        {
            code.Add(5);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("Six"))
        {
            code.Add(6);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("Seven"))
        {
            code.Add(7);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("Eight"))
        {
            code.Add(8);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("Nine"))
        {
            code.Add(9);
            hit.Play();
        }
		else if (other.gameObject.CompareTag("Green"))
		{
            hit.Play();
            if(code.Count == rightCode.Count)
            {
                for (int i = 0; i < rightCode.Count; i++)
                {
                    if (rightCode[i] != code[i])
                    {
                        code = new ArrayList();
                        break;
                    }
                    if(i == rightCode.Count - 1)
                    {
                        open = true;
                    }
                }
            }
            else
            {
                code = new ArrayList();
            }

		}
		else if (other.gameObject.CompareTag("Red"))
		{
			//wrong.Play();
			hit.Play();
			code = new ArrayList();
		}

        //System.Threading.Thread.Sleep(2000);


    }
}
