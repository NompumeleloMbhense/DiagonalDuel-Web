window.bootstrapInterop = {
    showModal: function (modalId) {
        var modalEl = document.querySelector(modalId);
        if (modalEl) {
            var modal = new bootstrap.Modal(modalEl);
            modal.show();
        }
    },
    hideModal: function (modalId) {
        var modalEl = document.querySelector(modalId);
        if (modalEl) {
            var modal = bootstrap.Modal.getInstance(modalEl);
            if (modal) modal.hide();
        }
    }
};
