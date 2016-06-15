package model;

import javafx.scene.control.TextArea;

import java.util.ArrayList;

public class Cards {
	private ArrayList<Card> cards;
	private String name;
	private boolean playerOwned;
    private double x,y;
    private final double CARDWIDTH = 50;

	public Cards(boolean owned) {
		cards = new ArrayList<>();
		playerOwned = owned;
        alignCards();
	}

    public Cards(String name, boolean owned) {
        this.name = name;
        cards = new ArrayList<>();
        this.playerOwned = owned;
        alignCards();
    }

	public void add(Card card) {
        cards.add(card);
        alignCards();
    }
    public Card remove(Card card) {
        for (int i = 0; i < cards.size(); i++) {
            Card temp = cards.get(i);
            if (temp.matches(card.toString())) {
                Card removedCard = cards.remove(i);
                alignCards();
                return removedCard;
            }
        }
        System.out.println(card.toString() + " failed to be removed");
        return null;
    }

	public Card get(int index) { return cards.get(index);}

	public Card get(String desc) {
		for (Card card : cards) {
			if (card.toString().equals(desc)) {return card;}
		}
		return null;
	}

    public String getName() {return name;}
    public void setName(String name) {
        this.name = name;
    }

    public void addValueToCard(String key, Object value, Object v) {
        for (Card card : cards) {
            if (card.hasAttribute(value)) {
                card.addAttribute(key, v);
            }
        }
    }

    public void alignCards() {
        for (int i = 0; i < cards.size(); i++) {
            double xcoord = x - CARDWIDTH - (CARDWIDTH * cards.size() / 2) + (i * CARDWIDTH);
            cards.get(i).setCenter(xcoord, y);
        }
    }

    public ArrayList<TextArea> getAll() {
        ArrayList<TextArea> ret = new ArrayList<>();
        for (Card card : cards) {
            ret.add(card.rect);
        }
        return ret;
    }

	public String toString() {
		String temp = name;
		for (Card card : cards) {
			temp += card.toString();
			temp += " | ";
		}
        if (temp.length() == name.length()) {return name + " empty collection";}
		return temp.trim();
	}

    public void setCenter(double x, double y) {
        this.x = x;
        this.y = y;
    }

    public boolean matchesWith(String toMatch) {
        return name.equals(toMatch);
    }
}
