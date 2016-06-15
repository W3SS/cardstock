package model;

import javafx.scene.control.TextField;
import javafx.scene.control.TextInputControl;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;

import java.util.ArrayList;

public class Player {
    public int id;
    private Circle circle;
    private TextField name;
    private ArrayList<Cards> playerCards;

    public Player(int id) {
        playerCards = new ArrayList<>();
        this.id = id;
        setupCircle();
        addNameField();
    }

    private void setupCircle() {
        this.circle = new Circle();
        circle.setRadius(150);
        circle.setFill(Color.CYAN);
    }

    private void addNameField(){
        name = new TextField();
        name.setEditable(false);
        name.setText("Player " + id);
        name.setLayoutX(circle.getCenterX() - 75);
        name.setLayoutY(circle.getCenterY() - 12.5);
    }

    public void setLocs() {
        double rads = (2 * Math.PI) / playerCards.size();
        int i = 0;
        for (Cards groups : playerCards) {
            double angle = rads * i + Math.PI;
            double x = circle.getCenterX() + (circle.getRadius() * .7 * Math.sin(angle));
            double y = circle.getCenterY() + (circle.getRadius() * .7 * Math.cos(angle)) - 35;
            groups.setCenter(x,y);

            i++;
        }
        addNameField();
    }

    public void setCenter(double x, double y) {
        circle.setCenterX(x);
        circle.setCenterY(y);
    }

    public ArrayList<TextInputControl> getAll() {
        ArrayList<TextInputControl> ret = new ArrayList<>();
        for (Cards groups : playerCards) {
            ret.addAll(groups.getAll());
        }
        ret.add(name);
        return ret;
    }

    private ArrayList<TextField> copy(ArrayList<TextField> fields) {
        ArrayList<TextField> ret = new ArrayList<>();
        for (TextField item : fields) {
            ret.add(item);
        }
        return ret;
    }

    public Circle getCircle() {
        return circle;
    }

    public Cards getCards(String toMatch) {
        for (Cards group : playerCards) {
            if (group.matchesWith(toMatch)) {
                return group;
            }
        }
        return addNewGroup(toMatch);
    }

    private Cards addNewGroup(String str) {
        Cards newCards = new Cards(str, true);
        playerCards.add(newCards);
        setLocs();
        return newCards;
    }

    public void addValueToCards(String key, String value, String v) {
        for (Cards cs : playerCards) {
            cs.addValueToCard(key, value, v);
        }
    }

    public boolean matchesWith(int playerId) {
        return id == playerId;
    }
}
