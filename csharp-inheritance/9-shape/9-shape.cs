using System;

class Shape
{
    public virtual int Area()
    {
         throw new NotImplementedException("Area() is not implemented");
    }
}
class Rectangle
{
    private int width;
    private int height;
    public int Width
    {
        get
        {
            return (width);
        }
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Width must be greater than or equal to 0");
			}
			else
			{
				width = value
			}
		}
    }
	public int Height
	{
		get
		{
			return (height);
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("height must be greater than or equal to 0");
			}
			else
			{
				height = value
			}
		}
	}
    public new int Area()
    {
        return (width * height);
    }
    public override string ToString()
    {
        return (string.Format("[Rectangle] {0} / {1}", width, height));
    }
    private int size;
    public int size
    {
        get
        {
            return (size);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            else
            {
                size = Height = Width = value;
            }
        }
    }
}

class Square : Rectangle
{
    private int size;
    public int size
    {
        get
        {
            return (size);
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");

            }
            else
            {
                size = Height = Width = value;
            }
        }
    }
    public override ToString()
    {
        return String.Format("[Square] {0} / {0}", size);
    }
}
