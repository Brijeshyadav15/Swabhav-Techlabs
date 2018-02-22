class Point {
    set X(val) {
        if (val > 0)
            this._x = val;
        else
            this._x = 0;
    }
    set Y(val) {
        if (val > 0)
            this._y = val;
        else
            this._y = 0;
    }
    get X() {
        return this._x;
    }
    get Y() {
        return this._y;
    }
}
let p1 = new Point();
p1.X = 10;
console.log(p1.X);
p1.Y = 20;
console.log(p1.Y);
