using System;
using System.Collections.Generic;
using Android.Support.Design.Widget;
using Android.Text;
using Android.Widget;
using FlexiMvvm;
using FlexiMvvm.Bindings;
using FlexiMvvm.Bindings.Custom;
using FlexiMvvm.Collections;

namespace VacationsTracker.Droid.Views.Bindings
{
    internal static class CustomBindings
    {
        public static TargetItemTwoWayCustomBinding<TextInputEditText, string, AfterTextChangedEventArgs>
        AfterTextChangedBinding(this IItemReference<TextInputEditText> reference)
        {
            return new TargetItemTwoWayCustomBinding<TextInputEditText, string, AfterTextChangedEventArgs>(
                reference,
                (editText, handler) => editText.AfterTextChanged += handler,
                (editText, handler) => editText.AfterTextChanged -= handler,
                (editText, canExecute) => { },
                (editText, eventArgs) => editText.Text,
                (editText, value) => editText.Text = value,
                () => nameof(TextInputEditText.AfterTextChanged));
        }

        public static TargetItemBinding<RecyclerViewObservableAdapter, object>
        ItemSelectedBinding(this IItemReference<RecyclerViewObservableAdapter> reference)
        {
            return new TargetItemOneWayToSourceCustomBinding<RecyclerViewObservableAdapter, object, SelectionChangedEventArgs>(
                reference,
                (recycleView, handler) => recycleView.ItemClicked += handler,
                (recycleView, handler) => recycleView.ItemClicked -= handler,
                (source, param) => { },
                (source, eventArgs) => eventArgs?.Item,
                () => nameof(RecyclerViewObservableAdapter.ItemClicked));
        }

        public static TargetItemBinding<TextInputLayout, string>
            ErrorBinding(this IItemReference<TextInputLayout> textInputLayoutReference)
        {
            return new TargetItemOneWayCustomBinding<TextInputLayout, string>(
                textInputLayoutReference,
                (textInputLayout, error) => textInputLayout.Error = error,
                () => nameof(TextInputLayout.Error));
        }

        public static TargetItemBinding<TextInputLayout, string>
            HintBinding(this IItemReference<TextInputLayout> textInputLayoutReference)
        {
            return new TargetItemOneWayCustomBinding<TextInputLayout, string>(
                textInputLayoutReference,
                (textInputLayout, hint) => textInputLayout.Hint = hint,
                () => nameof(TextInputLayout.Hint));
        }

        public static TargetItemBinding<TextInputLayout, bool>
            ErrorEnabledBinding(this IItemReference<TextInputLayout> textInputLayoutReference)
        {
            return new TargetItemOneWayCustomBinding<TextInputLayout, bool>(
                textInputLayoutReference,
                (textInputLayout, errorEnabled) => textInputLayout.ErrorEnabled = errorEnabled,
                () => nameof(TextInputLayout.ErrorEnabled));
        }

        public static TargetItemBinding<TextInputEditText, InputTypes>
            InputTypeBinding(this IItemReference<TextInputEditText> textInputEditTextReference)
        {
            return new TargetItemOneWayCustomBinding<TextInputEditText, InputTypes>(
                textInputEditTextReference,
                (textInputEditText, inputTypes) => textInputEditText.InputType = inputTypes,
                () => nameof(TextInputEditText.InputType));
        }

        public static TargetItemBinding<RecyclerViewObservablePlainAdapter, IEnumerable<object>> ItemsBinding(
            this IItemReference<RecyclerViewObservablePlainAdapter> recyclerViewAdapterReference)
        {
            if (recyclerViewAdapterReference == null)
                throw new ArgumentNullException(nameof(recyclerViewAdapterReference));

            return new TargetItemOneWayCustomBinding<RecyclerViewObservablePlainAdapter, IEnumerable<object>>(
                recyclerViewAdapterReference,
                (recyclerViewAdapter, items) => recyclerViewAdapter.Items = items,
                () => nameof(RecyclerViewObservablePlainAdapter.Items));
        }

        public static TargetItemBinding<FragmentPagerObservableAdapter, IEnumerable<object>> ItemsBinding(
            this IItemReference<FragmentPagerObservableAdapter> fragmentPagerViewAdapterReference)
        {
            if (fragmentPagerViewAdapterReference == null)
                throw new ArgumentNullException(nameof(fragmentPagerViewAdapterReference));

            return new TargetItemOneWayCustomBinding<FragmentPagerObservableAdapter, IEnumerable<object>>(
                fragmentPagerViewAdapterReference,
                (pagerObservableAdapter, items) => pagerObservableAdapter.Items = items,
                () => nameof(FragmentPagerObservableAdapter.Items));
        }

        public static TargetItemBinding<Spinner, object>
        ItemSelectedBinding(this IItemReference<Spinner> reference)
        {
            return new TargetItemTwoWayCustomBinding<Spinner, object, AdapterView.ItemSelectedEventArgs>(
                reference,
                (spinnerView, handler) => spinnerView.ItemSelected += handler,
                (spinnerView, handler) => spinnerView.ItemSelected -= handler,
                (source, param) => { },
                (source, eventArgs) => (string)source.SelectedItem,
                (source, value) =>
                {
                    var itemPosition = ((ArrayAdapter)source.Adapter).GetPosition((Java.Lang.Object)value);
                    source.SetSelection(itemPosition);
                },
                () => nameof(Spinner.ItemSelected));
        }

        public static TargetItemBinding<ImageButton, int> SetImageResourceBinding(
            this IItemReference<ImageButton> buttonReference)
        {
            return new TargetItemOneWayCustomBinding<ImageButton, int>(
                buttonReference,
                (button, imageId) => button.NotNull().SetImageResource(imageId),
                () => "SetImage");
        }
    }
}