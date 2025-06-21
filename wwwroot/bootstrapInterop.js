
  window.bootstrapInterop = {
    showModal: (id) => {
      var modal = new bootstrap.Modal(document.querySelector(id));
      modal.show();
    },
    hideModal: (id) => {
      var modalEl = document.querySelector(id);
      var modal = bootstrap.Modal.getInstance(modalEl);
      modal?.hide();
    }
  };

