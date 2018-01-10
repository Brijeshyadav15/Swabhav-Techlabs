package lsp.violation;

public class Square extends Rectangle {
	public Square(int side) {
		super(side, side);
		this.side = side;
	}

	private int side;

	@Override
	public void setWidth(int width) {
		this.width = this.height= width;
	}

	@Override
	public void setHeight(int height) {
		this.width = this.height= height;
	}
}
