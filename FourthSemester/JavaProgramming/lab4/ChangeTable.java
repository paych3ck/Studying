import java.util.Arrays;
import java.util.ArrayList;

import java.text.ParseException;

import java.awt.*;
import java.awt.event.*;

import javax.swing.*;
import javax.swing.event.*;
import javax.swing.table.*;

public class ChangeTable implements TableModelListener {
	private ArrayList<Carrier> carriers = new ArrayList<Carrier>();

    private TableModel tblModel;

	private JTable tbl;
	
    private JFrame frm = new JFrame("Грузоперевозчики");

	private JPanel panel1 = new JPanel();
	private JPanel panel2 = new JPanel();

    private JTextField type = new JTextField(10);
    private JTextField name = new JTextField(10);
    private JTextField weight = new JTextField(10);
    private JTextField priceperkg = new JTextField(5);

    private JCheckBox isCarriage = new JCheckBox();

    private JButton bAdd = new JButton("Добавить");
    private JButton bClear = new JButton("Удалить");

	public ChangeTable() throws ParseException {
		panel1.setLayout(new BorderLayout());
		panel2.setLayout(new FlowLayout());

		bAdd.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				try {
					carriers.add(new Carrier(type.getText(), name.getText(), Integer.parseInt(weight.getText()), Integer.parseInt(priceperkg.getText()), isCarriage.isSelected()));
					} catch (NumberFormatException ev) {
						ev.printStackTrace();
					}
				((AbstractTableModel) tblModel).fireTableDataChanged();
				tbl.updateUI();
				}
        });

        bClear.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent e) {
                type.setText("");
                name.setText("");
                weight.setText("");
                priceperkg.setText("");
                isCarriage.setSelected(false);
            }
        });

        frm.setLayout(new BorderLayout());
        frm.setSize(600, 200);
        frm.setLocation(300, 300);
        frm.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        Carrier[] crr = new Carrier[5];
        crr[0] = new Carrier("Поезд", "TGV", 100, 30, Boolean.TRUE);
        crr[1] = new Carrier("Поезд", "Talgo", 100, 30, Boolean.FALSE);
        crr[2] = new Carrier("Поезд", "Maglev", 250, 20, Boolean.TRUE);
        crr[3] = new Carrier("Машина", "Toyota Camry", 210, 36, Boolean.FALSE);
        crr[4] = new Carrier("Машина", "Kia Rio", 210, 36, Boolean.TRUE);
        carriers = new ArrayList<Carrier>(Arrays.asList(crr));
        tblModel = new TableModel(carriers);
        tblModel.addTableModelListener(this);
        tbl = new JTable(tblModel);

        RowSorter<TableModel> sorter = new TableRowSorter<TableModel>((TableModel) tblModel);
        tbl.setRowSorter(sorter);
        JScrollPane scroll = new JScrollPane(tbl);
        tbl.setPreferredScrollableViewportSize(new Dimension(600, 100));
        panel1.add(scroll);
        panel2.add(type);
        panel2.add(name);
        panel2.add(weight);
        panel2.add(priceperkg);
        panel2.add(isCarriage);
        panel2.add(bAdd);
        panel2.add(bClear);

        frm.getContentPane().add(panel1, BorderLayout.CENTER);
        frm.getContentPane().add(panel2, BorderLayout.SOUTH);
        frm.setVisible(true);
        frm.pack();
    }

    @Override
    public void tableChanged(TableModelEvent e) {
        int row = e.getFirstRow();
        int column = e.getColumn();
        TableModel model = (TableModel) e.getSource();
        String columnName = model.getColumnName(column);
        Object data = model.getValueAt(row, column);        
    }
}