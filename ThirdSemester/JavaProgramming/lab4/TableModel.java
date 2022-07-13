import javax.swing.table.AbstractTableModel;
import java.util.ArrayList;

public class TableModel extends AbstractTableModel {
	ArrayList<Carrier> carriers;

	public TableModel(ArrayList<Carrier> carriers) {
		super();
		this.carriers = carriers;
	}

	@Override
	public int getRowCount() {
		return carriers.size();
	}

	@Override
	public int getColumnCount() {
		return 5;
	}

	@Override
	public String getColumnName(int c) {
		String result = "";
		switch (c) {
			case 0:
				result = "Тип ТС";
				break;

			case 1:
				result = "Название";
				break;

			case 2:
				result = "Максимальный объем груза";
				break;

			case 3:
				result = "Цена за КГ";
				break;

			case 4:
				result = "Перевозка животных";
				break;
		}
	return result;
	}

	@Override
	public Class getColumnClass(int c) {
		return getValueAt(0, c).getClass();
	}

	@Override
	public Object getValueAt(int r, int c) {
		switch (c) {
			case 0:
				return carriers.get(r).getType();

			case 1:
				return carriers.get(r).getName();

			case 2:
				return carriers.get(r).getWeight();

			case 3: 
				return carriers.get(r).getPriceperkg();

			case 4: 
				return (Boolean)carriers.get(r).getIsCarriage();

			default:
				return "";
		}
	}
}