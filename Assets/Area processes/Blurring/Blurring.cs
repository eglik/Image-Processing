﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AreaProcesses
{
    public class Blurring : MonoBehaviour
    {
        public Texture2D texture;

        private void Start()
        {
            float[,] matrix7x7 = {
            { 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f },
            { 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f },
            { 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f },
            { 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f },
            { 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f },
            { 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f },
            { 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f, 1/49f } };


            float[,] matrix15x15 = {
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f },
            { 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f, 1/255f } };

            ConvolutionMask c = new ConvolutionMask(matrix15x15, texture);
            GetComponent<RawImage>().texture = c.GetTexture();
        }
    }
}