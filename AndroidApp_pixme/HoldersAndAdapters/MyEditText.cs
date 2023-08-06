using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;
using Android.Content.Res;

namespace PixmeApp
{
    public class MyEditText : LinearLayout
    {
        private TextView txtView;
        private EditText editText;

        public MyEditText(Context context) : base(context)
        {
            Init(context, null);
        }

        public MyEditText(Context context, IAttributeSet attrs) : base(context, attrs)
        {
            Init(context, attrs);
        }

        public MyEditText(Context context, IAttributeSet attrs, int defStyleAttr) : base(context, attrs, defStyleAttr)
        {
            Init(context, attrs);
        }

        public MyEditText(Context context, IAttributeSet attrs, int defStyleAttr, int defStyleRes) : base(context, attrs, defStyleAttr, defStyleRes)
        {
            Init(context, attrs);
        }

        private void Init(Context contextt, IAttributeSet attrs)
        {
            Inflate(contextt, Resource.Layout.view_my_edit_text, this);


            txtView = FindViewById<TextView>(Resource.Id.txt);
            editText = FindViewById<EditText>(Resource.Id.edt);

            if (attrs != null)
            {
                TypedArray a = Context.ObtainStyledAttributes(attrs, Resource.Styleable.MyEditText);
                try
                {
                    if (a.HasValue(Resource.Styleable.MyEditText_android_text))
                    {
                        txtView.SetText(a.GetResourceId(Resource.Styleable.MyEditText_android_text, -1));
                    }
                }
                catch (Exception e)
                {
                }
                a.Recycle();

            }
        }


        public TextView GetTxtView()
        {
            return txtView;
        }

        public EditText GetEditText()
        {
            return editText;
        }
    }
}