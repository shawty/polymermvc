$(document).ready(function () {
    $("form").bind("invalid-form.validate", function (form) {
        $('.bmvc-3-validation-summary').addClass('alert alert-danger').find('.close').show();
    });

    if ($.validator) {
        $.validator.setDefaults({
            highlight: function(element) {
                $(element).closest(".control-group").addClass("error");
                $(element).closest(".form-group").addClass("has-error");
            },
            unhighlight: function(element) {
                $(element).closest(".control-group").removeClass("error");
                $(element).closest(".form-group").removeClass("has-error");
            }
        });
    }

    $('[rel=tooltip]').tooltip();
    $('[rel=popover]').popover();

    $(function () {
        $('[data-provide=typeahead]').each(function () {
            var self = $(this);
            self.typeahead({
                source: function (term, process) {
                    var url = self.data('url');

                    return $.getJSON(url, { term: term }, function (data) {
                        return process(data);
                    });
                }
            });
        });
        
        $('[data-disabled-depends-on]').each(function () {
            var self = $(this);
            var name = self.data('disabled-depends-on');
            var val = self.data('disabled-depends-val');
            var selector = '[name="' + name + '"]';

            $(document).on('change', selector + ':checkbox', function () {
                self.prop('disabled', $(this).prop('checked') == val);
            });

            $(document).on('change', selector + ':not(:checkbox):not(:hidden)', function () {
                self.prop('disabled', $(this).val().toString() == val.toString());
            });
            $(selector).change();
        });
        
        var isFirstRun = true;
        $('[data-visible-depends-on]').each(function () {
            var self = $(this);
            var name = self.data('visible-depends-on');
            var val = self.data('visible-depends-val');
            var speed = self.data('visible-depends-speed');
            var selector = '[name="' + name + '"]';
            var selfName = self.attr('name');
            var toHide;

            if (self.is('div')) {
                toHide = self;
            } else {
                var formGroup = self.closest('.form-group');
                if (formGroup.length > 0 && formGroup.find('input:not(:hidden):not([name="' + selfName + '"]),select:not([name="' + selfName + '"]),textarea:not([name="' + selfName + '"])').length === 0) {
                    toHide = formGroup;
                } else {
                    toHide = $('[name="' + selfName + '"],label[for="' + selfName + '"]');
                }
            }

            $(document).on('change', selector + ':checkbox', function () {
                if ($(this).prop('checked') == val) {
                    toHide.show(isFirstRun ? undefined : speed);
                } else {
                    toHide.hide(isFirstRun ? undefined : speed);
                }
            });

            $(document).on('change', selector + ':not(:checkbox):not(:hidden)', function () {
                if ($(this).val() == val) {
                    toHide.show(isFirstRun ? undefined : speed);
                } else {
                    toHide.hide(isFirstRun ? undefined : speed);
                }
            });

            if ($(selector).is(':radio')) {
                $(selector + ':checked').change();
            } else {
                $(selector).change();
            }
            isFirstRun = false;
        });
    });
});

