using System;
using FlexiMvvm;
using FlexiMvvm.Bindings;
using FlexiMvvm.Bindings.Custom;
using UIKit;

namespace VacationsTracker.iOS.Views.Bindings
{
    internal static class CustomBindings
    {
        internal static TargetItemBinding<UITextField, UIKeyboardType> KeyboardTypeBinding(
            this IItemReference<UITextField> textFieldItem)
        {
            return new TargetItemOneWayCustomBinding<UITextField, UIKeyboardType>(
                textFieldItem,
                (textField, keyboardType) => textField.KeyboardType = keyboardType,
                () => nameof(UITextField.KeyboardType));
        }

        internal static TargetItemBinding<UIButton, UIImage> SetImageBinding(
            this IItemReference<UIButton> buttonReference,
            UIControlState forState = UIControlState.Normal)
        {
            if (buttonReference == null)
                throw new ArgumentNullException(nameof(buttonReference));

            return new TargetItemOneWayCustomBinding<UIButton, UIImage>(
                buttonReference,
                (button, image) => button.NotNull().SetImage(image, forState),
                () => "SetImage");
        }
    }
}