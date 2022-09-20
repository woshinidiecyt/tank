﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_坦克大战_开始
{
    //不可移动的物体
    internal class NotMovething:GameObject
    {
        private Image img;
        public Image Img { 
            get { return img; }
            set 
            { 
                img = value; 
                Width = img.Width;
                Height = img.Height;
            } 
        }

        protected override Image GetImage()
        {
           return Img;
        }

        public NotMovething(int x,int y,Image img)
        {
            this.X = x;
            this.Y = y;
            this.Img = img;
        }
    }
}
