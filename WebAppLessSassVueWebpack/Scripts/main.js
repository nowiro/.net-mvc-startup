var app = new Vue({
    el: '#app',
    data: {
        message: 'Hello Vue!'
    }
});

var app4 = new Vue({
    el: '#app-4',
    data: {
        todos: [
            { text: 'Learn JavaScript' },
            { text: 'Learn Vue' },
            { text: 'Build something awesome' }
        ]
    }
});

var app6 = new Vue({
    el: '#app-6',
    data: {
        message: 'Hello Vue!'
    }
});




// register modal component
Vue.component('modal',
{
    template: '#modal-template'
});

Vue.component('modal2',
{
    template: '#modal-template'
});

// start app
var _showModal = new Vue({
    el: '#appmodal',
    data: {
        showModal: false
    }
});

var _showModal2 = new Vue({
    el: '#appmodal2',
    data: {
        showModal2: false
    }
});


var _showAlert = new Vue({
    el: '#appalert',
    data: {
        showAlert: false
    }
});
