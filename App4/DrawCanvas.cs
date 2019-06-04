﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace App4
{
    public class DrawCanvas : View
    {
        public int[] x = new int[1000];
        public int[] y = new int[1000];
        public int[] c = new int[100];
        public Random rnd = new Random();

        public int cx = 500;
        public int cy = 500;

        public DrawCanvas(Context context) : base(context)
        {
        }

        public DrawCanvas(Context context, IAttributeSet attrs) : base(context, attrs)
        {
        }

        public DrawCanvas(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
        }

        public DrawCanvas(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
        }

        protected DrawCanvas(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        protected override void OnDraw(Canvas canvas)
        {
            //base.OnDraw(canvas);

            Paint paint = new Paint();
            canvas.DrawLine(250, 250, 250, 500, paint);
            canvas.DrawLine(350, 250, 350, 500, paint);
            canvas.DrawLine(450, 250, 450, 500, paint);
            canvas.DrawLine(250, 500, 450, 500, paint);
        }
    }
}