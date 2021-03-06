﻿using System;
using System.Collections.Generic;

namespace Atomiv.Core.Common.WebAutomation
{
    public interface IFinder<TElementRoot, TElement, TTextBox, TCheckBox, TComboBox, TButton, TRadioButton, TRadioButtonGroup, TCheckBoxGroup, TCompositeElement>
        where TElementRoot : IElementRoot<TElementRoot, TElement, TTextBox, TCheckBox, TComboBox, TButton, TRadioButton, TRadioButtonGroup, TCheckBoxGroup, TCompositeElement>
        where TElement : IElement
        where TTextBox : ITextBox
        where TCheckBox : ICheckBox
        where TComboBox : IComboBox
        where TButton : IButton
        where TRadioButton : IRadioButton
        where TRadioButtonGroup : IRadioButtonGroup
        where TCheckBoxGroup : ICheckBoxGroup
        where TCompositeElement : ICompositeElement
    {
        TElement FindElement(IQuery query);

        IEnumerable<TElement> FindElements(IQuery query);

        TTextBox FindTextBox(IQuery query);

        IEnumerable<TTextBox> FindTextBoxes(IQuery query);

        TCheckBox FindCheckBox(IQuery query);

        IEnumerable<TCheckBox> FindCheckBoxes(IQuery query);

        TComboBox FindComboBox(IQuery query);

        IEnumerable<TComboBox> FindComboBoxes(IQuery query);

        TButton FindButton(IQuery query);

        IEnumerable<TButton> FindButtons(IQuery query);

        TRadioButton FindRadioButton(IQuery query);

        IEnumerable<TRadioButton> FindRadioButtons(IQuery query);

        TRadioButtonGroup FindRadioButtonGroup(IQuery query);

        TCheckBoxGroup FindCheckBoxGroup(IQuery query);

        T FindElement<T>(IQuery query, Func<TElementRoot, T> create);

        IEnumerable<T> FindElements<T>(IQuery query, Func<TElementRoot, T> create);

        T FindElement<T>(IQuery query) where T : TCompositeElement;

        IEnumerable<T> FindElements<T>(IQuery query) where T : TCompositeElement;
    }
}