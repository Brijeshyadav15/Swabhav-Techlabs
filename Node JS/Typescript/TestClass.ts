class Point{
    private _x:number;
    private _y:number;

    public set X(val:number)
    {
        if(val >0)
            this._x=val
        else
            this._x=0
    }

    public set Y(val:number)
    {
        if(val >0)
            this._y=val
        else
            this._y=0
    }
    
    public get X()
    {
        return this._x;
    }
    public get Y()
    {
        return this._y;
    }
}

let p1 = new Point();
p1.X= 10;
console.log(p1.X);
p1.Y = 20;
console.log(p1.Y);