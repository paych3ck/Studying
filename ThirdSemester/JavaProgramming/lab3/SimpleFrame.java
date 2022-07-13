import javax.swing.*;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class SimpleFrame extends JFrame {
    private JPanel panel = new JPanel();
    private JLabel label = new JLabel("Текст");
    private JMenu items = new JMenu("Пункты");

    String s1 = "Первый пункт";
    private JMenuItem n1 = new JMenuItem(s1);

    String s2 = "Второй пункт";
    private JMenuItem n2 = new JMenuItem(s2);

    String s3 = "Третий пункт";
    private JMenuItem n3 = new JMenuItem(s3);

    String s4 = "Четвертый пункт";
    private JMenuItem n4 = new JMenuItem(s4);

    public SimpleFrame(int l, int t, int w, int h) {
        add(panel);
        panel.add(label);

        items.add(n1);
        n1.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent ev) 
            {
                label.setText(s1);
                System.out.println(s1);
            }
        });

        items.add(n2);
        n2.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent ev) 
            {
                label.setText(s2);
                System.out.println(s2);
            }
        });

        items.add(n3);
        n3.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent ev) 
            {
                label.setText(s3);
                System.out.println(s3);
            }
        });

        items.add(n4);
        n4.addActionListener(new ActionListener() {
            public void actionPerformed(ActionEvent ev) 
            {
                label.setText(s4);
                System.out.println(s4);
            }
        });

        JMenuBar mainMenu = new JMenuBar();
        mainMenu.add(items);
        setJMenuBar(mainMenu);

        setSize(w, h);
        setLocation(l, t);
        setTitle("Лабораторная работа №3");
        
    }
}